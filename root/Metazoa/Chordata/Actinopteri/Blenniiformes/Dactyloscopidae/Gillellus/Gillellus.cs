using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Dactyloscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Dactyloscopidae.Gillellus;

/// <summary>
/// Abstract class for Gillellus (genus).
/// NCBI TaxId: 390334
/// </summary>
public abstract class Gillellus : Dactyloscopidae, IGillellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gillellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390334;

    /// <inheritdoc />
    public virtual string GenusName => "Gillellus";

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
