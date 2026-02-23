using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Leiothlypis;

/// <summary>
/// Abstract class for Leiothlypis (genus).
/// NCBI TaxId: 1610823
/// </summary>
public abstract class Leiothlypis : Parulidae, ILeiothlypis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiothlypis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1610823;

    /// <inheritdoc />
    public virtual string GenusName => "Leiothlypis";

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
