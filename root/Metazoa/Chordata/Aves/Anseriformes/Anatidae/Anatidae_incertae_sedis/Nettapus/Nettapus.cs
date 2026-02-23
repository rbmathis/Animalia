using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anatidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anatidae_incertae_sedis.Nettapus;

/// <summary>
/// Abstract class for Nettapus (genus).
/// NCBI TaxId: 45640
/// </summary>
public abstract class Nettapus : Anatidae_incertae_sedis, INettapus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nettapus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 45640;

    /// <inheritdoc />
    public virtual string GenusName => "Nettapus";

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
