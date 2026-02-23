using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Dendrocygna;

/// <summary>
/// Abstract class for Dendrocygna (genus).
/// NCBI TaxId: 8870
/// </summary>
public abstract class Dendrocygna : Anatidae, IDendrocygna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrocygna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8870;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrocygna";

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
