using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Dalophia;

/// <summary>
/// Abstract class for Dalophia (genus).
/// NCBI TaxId: 1395497
/// </summary>
public abstract class Dalophia : Amphisbaenidae, IDalophia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dalophia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1395497;

    /// <inheritdoc />
    public virtual string GenusName => "Dalophia";

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
