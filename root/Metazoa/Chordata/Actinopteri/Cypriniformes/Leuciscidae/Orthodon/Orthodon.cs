using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Orthodon;

/// <summary>
/// Abstract class for Orthodon (genus).
/// NCBI TaxId: 71766
/// </summary>
public abstract class Orthodon : Leuciscidae, IOrthodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orthodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71766;

    /// <inheritdoc />
    public virtual string GenusName => "Orthodon";

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
