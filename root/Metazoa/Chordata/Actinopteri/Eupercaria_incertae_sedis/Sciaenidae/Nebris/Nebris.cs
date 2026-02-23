using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Nebris;

/// <summary>
/// Abstract class for Nebris (genus).
/// NCBI TaxId: 278763
/// </summary>
public abstract class Nebris : Sciaenidae, INebris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nebris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 278763;

    /// <inheritdoc />
    public virtual string GenusName => "Nebris";

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
