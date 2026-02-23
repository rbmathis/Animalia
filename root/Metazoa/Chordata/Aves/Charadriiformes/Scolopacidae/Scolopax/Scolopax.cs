using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Scolopax;

/// <summary>
/// Abstract class for Scolopax (genus).
/// NCBI TaxId: 56298
/// </summary>
public abstract class Scolopax : Scolopacidae, IScolopax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scolopax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56298;

    /// <inheritdoc />
    public virtual string GenusName => "Scolopax";

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
