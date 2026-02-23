using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Hemiphaga;

/// <summary>
/// Abstract class for Hemiphaga (genus).
/// NCBI TaxId: 262123
/// </summary>
public abstract class Hemiphaga : Columbidae, IHemiphaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiphaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 262123;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiphaga";

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
