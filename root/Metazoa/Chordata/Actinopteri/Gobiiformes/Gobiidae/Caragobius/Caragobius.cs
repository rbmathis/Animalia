using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Caragobius;

/// <summary>
/// Abstract class for Caragobius (genus).
/// NCBI TaxId: 508030
/// </summary>
public abstract class Caragobius : Gobiidae, ICaragobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caragobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 508030;

    /// <inheritdoc />
    public virtual string GenusName => "Caragobius";

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
