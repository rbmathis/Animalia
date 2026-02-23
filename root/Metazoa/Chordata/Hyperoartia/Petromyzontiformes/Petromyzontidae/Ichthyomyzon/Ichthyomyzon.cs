using AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Ichthyomyzon;

/// <summary>
/// Abstract class for Ichthyomyzon (genus).
/// NCBI TaxId: 7772
/// </summary>
public abstract class Ichthyomyzon : Petromyzontidae, IIchthyomyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ichthyomyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7772;

    /// <inheritdoc />
    public virtual string GenusName => "Ichthyomyzon";

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
