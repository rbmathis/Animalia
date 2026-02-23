using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae.Heteroscarus;

/// <summary>
/// Abstract class for Heteroscarus (genus).
/// NCBI TaxId: 1582964
/// </summary>
public abstract class Heteroscarus : Odacidae, IHeteroscarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteroscarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1582964;

    /// <inheritdoc />
    public virtual string GenusName => "Heteroscarus";

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
