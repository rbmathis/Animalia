using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Lophonetta;

/// <summary>
/// Abstract class for Lophonetta (genus).
/// NCBI TaxId: 75872
/// </summary>
public abstract class Lophonetta : Anatidae, ILophonetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophonetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75872;

    /// <inheritdoc />
    public virtual string GenusName => "Lophonetta";

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
