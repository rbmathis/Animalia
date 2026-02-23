using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Retropinnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Retropinnidae.Stokellia;

/// <summary>
/// Abstract class for Stokellia (genus).
/// NCBI TaxId: 182224
/// </summary>
public abstract class Stokellia : Retropinnidae, IStokellia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stokellia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182224;

    /// <inheritdoc />
    public virtual string GenusName => "Stokellia";

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
