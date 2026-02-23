using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Hemignathus;

/// <summary>
/// Abstract class for Hemignathus (genus).
/// NCBI TaxId: 64797
/// </summary>
public abstract class Hemignathus : Fringillidae, IHemignathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemignathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 64797;

    /// <inheritdoc />
    public virtual string GenusName => "Hemignathus";

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
