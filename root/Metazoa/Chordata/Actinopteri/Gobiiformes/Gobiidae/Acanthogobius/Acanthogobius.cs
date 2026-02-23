using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Acanthogobius;

/// <summary>
/// Abstract class for Acanthogobius (genus).
/// NCBI TaxId: 86196
/// </summary>
public abstract class Acanthogobius : Gobiidae, IAcanthogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86196;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthogobius";

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
