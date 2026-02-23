using AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelomedusa;

/// <summary>
/// Abstract class for Pelomedusa (genus).
/// NCBI TaxId: 44521
/// </summary>
public abstract class Pelomedusa : Pelomedusidae, IPelomedusa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelomedusa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44521;

    /// <inheritdoc />
    public virtual string GenusName => "Pelomedusa";

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
