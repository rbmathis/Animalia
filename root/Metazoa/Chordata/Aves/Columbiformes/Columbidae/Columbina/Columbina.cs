using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Columbina;

/// <summary>
/// Abstract class for Columbina (genus).
/// NCBI TaxId: 111973
/// </summary>
public abstract class Columbina : Columbidae, IColumbina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Columbina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111973;

    /// <inheritdoc />
    public virtual string GenusName => "Columbina";

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
