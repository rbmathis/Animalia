using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Dactyloscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Dactyloscopidae.Platygillellus;

/// <summary>
/// Abstract class for Platygillellus (genus).
/// NCBI TaxId: 879883
/// </summary>
public abstract class Platygillellus : Dactyloscopidae, IPlatygillellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platygillellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879883;

    /// <inheritdoc />
    public virtual string GenusName => "Platygillellus";

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
