using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Dipodomys;

/// <summary>
/// Abstract class for Dipodomys (genus).
/// NCBI TaxId: 10016
/// </summary>
public abstract class Dipodomys : Heteromyidae, IDipodomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dipodomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10016;

    /// <inheritdoc />
    public virtual string GenusName => "Dipodomys";

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
