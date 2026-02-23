using AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Caspiomyzon;

/// <summary>
/// Abstract class for Caspiomyzon (genus).
/// NCBI TaxId: 682870
/// </summary>
public abstract class Caspiomyzon : Petromyzontidae, ICaspiomyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caspiomyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 682870;

    /// <inheritdoc />
    public virtual string GenusName => "Caspiomyzon";

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
