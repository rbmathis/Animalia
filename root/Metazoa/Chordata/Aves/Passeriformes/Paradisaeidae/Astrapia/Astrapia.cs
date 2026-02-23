using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Astrapia;

/// <summary>
/// Abstract class for Astrapia (genus).
/// NCBI TaxId: 681182
/// </summary>
public abstract class Astrapia : Paradisaeidae, IAstrapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Astrapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681182;

    /// <inheritdoc />
    public virtual string GenusName => "Astrapia";

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
