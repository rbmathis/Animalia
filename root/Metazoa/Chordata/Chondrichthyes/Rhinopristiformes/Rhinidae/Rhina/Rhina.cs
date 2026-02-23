using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinidae.Rhina;

/// <summary>
/// Abstract class for Rhina (genus).
/// NCBI TaxId: 117885
/// </summary>
public abstract class Rhina : Rhinidae, IRhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117885;

    /// <inheritdoc />
    public virtual string GenusName => "Rhina";

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
