using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Uromyias;

/// <summary>
/// Abstract class for Uromyias (genus).
/// NCBI TaxId: 83305
/// </summary>
public abstract class Uromyias : Tyrannidae, IUromyias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uromyias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83305;

    /// <inheritdoc />
    public virtual string GenusName => "Uromyias";

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
