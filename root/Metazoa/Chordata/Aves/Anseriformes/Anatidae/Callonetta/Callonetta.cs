using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Callonetta;

/// <summary>
/// Abstract class for Callonetta (genus).
/// NCBI TaxId: 75870
/// </summary>
public abstract class Callonetta : Anatidae, ICallonetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callonetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75870;

    /// <inheritdoc />
    public virtual string GenusName => "Callonetta";

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
