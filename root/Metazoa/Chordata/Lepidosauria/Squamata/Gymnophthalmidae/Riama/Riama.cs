using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Riama;

/// <summary>
/// Abstract class for Riama (genus).
/// NCBI TaxId: 1333649
/// </summary>
public abstract class Riama : Gymnophthalmidae, IRiama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Riama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1333649;

    /// <inheritdoc />
    public virtual string GenusName => "Riama";

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
