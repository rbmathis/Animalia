using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae.Nannatherina;

/// <summary>
/// Abstract class for Nannatherina (genus).
/// NCBI TaxId: 135767
/// </summary>
public abstract class Nannatherina : Percichthyidae, INannatherina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannatherina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135767;

    /// <inheritdoc />
    public virtual string GenusName => "Nannatherina";

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
