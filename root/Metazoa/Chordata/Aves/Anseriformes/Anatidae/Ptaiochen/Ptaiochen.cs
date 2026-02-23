using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Ptaiochen;

/// <summary>
/// Abstract class for Ptaiochen (genus).
/// NCBI TaxId: 107027
/// </summary>
public abstract class Ptaiochen : Anatidae, IPtaiochen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptaiochen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107027;

    /// <inheritdoc />
    public virtual string GenusName => "Ptaiochen";

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
