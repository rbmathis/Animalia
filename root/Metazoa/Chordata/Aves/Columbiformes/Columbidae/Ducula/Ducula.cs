using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Ducula;

/// <summary>
/// Abstract class for Ducula (genus).
/// NCBI TaxId: 115625
/// </summary>
public abstract class Ducula : Columbidae, IDucula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ducula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 115625;

    /// <inheritdoc />
    public virtual string GenusName => "Ducula";

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
