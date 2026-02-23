using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae.Gymnochanda;

/// <summary>
/// Abstract class for Gymnochanda (genus).
/// NCBI TaxId: 1828468
/// </summary>
public abstract class Gymnochanda : Ambassidae, IGymnochanda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnochanda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1828468;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnochanda";

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
