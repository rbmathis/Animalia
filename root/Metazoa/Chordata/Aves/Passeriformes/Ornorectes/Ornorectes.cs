using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ornorectes;

/// <summary>
/// Abstract class for Ornorectes (genus).
/// NCBI TaxId: 2497060
/// </summary>
public abstract class Ornorectes : Passeriformes, IOrnorectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ornorectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2497060;

    /// <inheritdoc />
    public virtual string GenusName => "Ornorectes";

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
