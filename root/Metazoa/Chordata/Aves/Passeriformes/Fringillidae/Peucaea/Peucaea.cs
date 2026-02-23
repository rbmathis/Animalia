using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Peucaea;

/// <summary>
/// Abstract class for Peucaea (genus).
/// NCBI TaxId: 1125616
/// </summary>
public abstract class Peucaea : Fringillidae, IPeucaea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Peucaea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1125616;

    /// <inheritdoc />
    public virtual string GenusName => "Peucaea";

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
