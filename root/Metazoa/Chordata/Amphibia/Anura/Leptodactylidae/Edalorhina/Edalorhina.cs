using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Edalorhina;

/// <summary>
/// Abstract class for Edalorhina (genus).
/// NCBI TaxId: 318277
/// </summary>
public abstract class Edalorhina : Leptodactylidae, IEdalorhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Edalorhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 318277;

    /// <inheritdoc />
    public virtual string GenusName => "Edalorhina";

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
