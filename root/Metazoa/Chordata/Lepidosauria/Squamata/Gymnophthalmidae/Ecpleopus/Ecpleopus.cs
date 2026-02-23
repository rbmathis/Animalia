using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Ecpleopus;

/// <summary>
/// Abstract class for Ecpleopus (genus).
/// NCBI TaxId: 174747
/// </summary>
public abstract class Ecpleopus : Gymnophthalmidae, IEcpleopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ecpleopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174747;

    /// <inheritdoc />
    public virtual string GenusName => "Ecpleopus";

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
