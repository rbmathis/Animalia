using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Bucephala;

/// <summary>
/// Abstract class for Bucephala (genus).
/// NCBI TaxId: 40832
/// </summary>
public abstract class Bucephala : Anatidae, IBucephala
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bucephala";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40832;

    /// <inheritdoc />
    public virtual string GenusName => "Bucephala";

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
