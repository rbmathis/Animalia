using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Assa;

/// <summary>
/// Abstract class for Assa (genus).
/// NCBI TaxId: 377306
/// </summary>
public abstract class Assa : Myobatrachidae, IAssa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Assa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 377306;

    /// <inheritdoc />
    public virtual string GenusName => "Assa";

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
