using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Dactyloscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Dactyloscopidae.Dactyloscopus;

/// <summary>
/// Abstract class for Dactyloscopus (genus).
/// NCBI TaxId: 879813
/// </summary>
public abstract class Dactyloscopus : Dactyloscopidae, IDactyloscopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dactyloscopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879813;

    /// <inheritdoc />
    public virtual string GenusName => "Dactyloscopus";

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
