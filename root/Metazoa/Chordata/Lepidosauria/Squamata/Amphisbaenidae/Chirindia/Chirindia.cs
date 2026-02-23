using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Chirindia;

/// <summary>
/// Abstract class for Chirindia (genus).
/// NCBI TaxId: 261481
/// </summary>
public abstract class Chirindia : Amphisbaenidae, IChirindia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chirindia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 261481;

    /// <inheritdoc />
    public virtual string GenusName => "Chirindia";

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
