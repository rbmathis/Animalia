using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Ochetobius;

/// <summary>
/// Abstract class for Ochetobius (genus).
/// NCBI TaxId: 143614
/// </summary>
public abstract class Ochetobius : Xenocyprididae, IOchetobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ochetobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143614;

    /// <inheritdoc />
    public virtual string GenusName => "Ochetobius";

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
