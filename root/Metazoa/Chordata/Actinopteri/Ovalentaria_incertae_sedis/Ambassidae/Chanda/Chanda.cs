using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae.Chanda;

/// <summary>
/// Abstract class for Chanda (genus).
/// NCBI TaxId: 205121
/// </summary>
public abstract class Chanda : Ambassidae, IChanda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chanda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 205121;

    /// <inheritdoc />
    public virtual string GenusName => "Chanda";

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
