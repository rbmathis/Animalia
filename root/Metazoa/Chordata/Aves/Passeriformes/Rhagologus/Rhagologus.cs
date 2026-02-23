using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhagologus;

/// <summary>
/// Abstract class for Rhagologus (genus).
/// NCBI TaxId: 156169
/// </summary>
public abstract class Rhagologus : Passeriformes, IRhagologus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhagologus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156169;

    /// <inheritdoc />
    public virtual string GenusName => "Rhagologus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
