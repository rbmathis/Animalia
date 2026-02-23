using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Sebastapistes;

/// <summary>
/// Abstract class for Sebastapistes (genus).
/// NCBI TaxId: 991003
/// </summary>
public abstract class Sebastapistes : Scorpaenidae, ISebastapistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sebastapistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 991003;

    /// <inheritdoc />
    public virtual string GenusName => "Sebastapistes";

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
