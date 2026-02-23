using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Neogastromyzon;

/// <summary>
/// Abstract class for Neogastromyzon (genus).
/// NCBI TaxId: 1081685
/// </summary>
public abstract class Neogastromyzon : Gastromyzontidae, INeogastromyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neogastromyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1081685;

    /// <inheritdoc />
    public virtual string GenusName => "Neogastromyzon";

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
