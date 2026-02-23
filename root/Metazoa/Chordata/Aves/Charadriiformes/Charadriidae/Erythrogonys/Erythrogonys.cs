using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Erythrogonys;

/// <summary>
/// Abstract class for Erythrogonys (genus).
/// NCBI TaxId: 425632
/// </summary>
public abstract class Erythrogonys : Charadriidae, IErythrogonys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erythrogonys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 425632;

    /// <inheritdoc />
    public virtual string GenusName => "Erythrogonys";

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
