using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Turtur;

/// <summary>
/// Abstract class for Turtur (genus).
/// NCBI TaxId: 187142
/// </summary>
public abstract class Turtur : Columbidae, ITurtur
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Turtur";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187142;

    /// <inheritdoc />
    public virtual string GenusName => "Turtur";

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
