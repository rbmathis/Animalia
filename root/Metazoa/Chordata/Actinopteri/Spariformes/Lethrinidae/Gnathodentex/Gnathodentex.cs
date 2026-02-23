using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae.Gnathodentex;

/// <summary>
/// Abstract class for Gnathodentex (genus).
/// NCBI TaxId: 490322
/// </summary>
public abstract class Gnathodentex : Lethrinidae, IGnathodentex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gnathodentex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490322;

    /// <inheritdoc />
    public virtual string GenusName => "Gnathodentex";

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
