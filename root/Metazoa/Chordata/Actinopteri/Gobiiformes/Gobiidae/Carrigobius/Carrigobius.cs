using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Carrigobius;

/// <summary>
/// Abstract class for Carrigobius (genus).
/// NCBI TaxId: 2008632
/// </summary>
public abstract class Carrigobius : Gobiidae, ICarrigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carrigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2008632;

    /// <inheritdoc />
    public virtual string GenusName => "Carrigobius";

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
