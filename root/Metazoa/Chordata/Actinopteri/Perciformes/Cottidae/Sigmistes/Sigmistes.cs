using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Sigmistes;

/// <summary>
/// Abstract class for Sigmistes (genus).
/// NCBI TaxId: 1638739
/// </summary>
public abstract class Sigmistes : Cottidae, ISigmistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sigmistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1638739;

    /// <inheritdoc />
    public virtual string GenusName => "Sigmistes";

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
