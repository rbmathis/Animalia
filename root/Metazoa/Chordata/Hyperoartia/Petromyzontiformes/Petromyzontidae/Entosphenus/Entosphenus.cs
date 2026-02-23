using AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Entosphenus;

/// <summary>
/// Abstract class for Entosphenus (genus).
/// NCBI TaxId: 171373
/// </summary>
public abstract class Entosphenus : Petromyzontidae, IEntosphenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Entosphenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 171373;

    /// <inheritdoc />
    public virtual string GenusName => "Entosphenus";

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
