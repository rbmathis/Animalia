using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Pseudohomaloptera;

/// <summary>
/// Abstract class for Pseudohomaloptera (genus).
/// NCBI TaxId: 1590169
/// </summary>
public abstract class Pseudohomaloptera : Balitoridae, IPseudohomaloptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudohomaloptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1590169;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudohomaloptera";

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
