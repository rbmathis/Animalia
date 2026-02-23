using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Monopeltis;

/// <summary>
/// Abstract class for Monopeltis (genus).
/// NCBI TaxId: 261479
/// </summary>
public abstract class Monopeltis : Amphisbaenidae, IMonopeltis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monopeltis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 261479;

    /// <inheritdoc />
    public virtual string GenusName => "Monopeltis";

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
