using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Namazonurus;

/// <summary>
/// Abstract class for Namazonurus (genus).
/// NCBI TaxId: 885510
/// </summary>
public abstract class Namazonurus : Cordylidae, INamazonurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Namazonurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 885510;

    /// <inheritdoc />
    public virtual string GenusName => "Namazonurus";

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
