using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Auriparus;

/// <summary>
/// Abstract class for Auriparus (genus).
/// NCBI TaxId: 142858
/// </summary>
public abstract class Auriparus : Certhiidae, IAuriparus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Auriparus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 142858;

    /// <inheritdoc />
    public virtual string GenusName => "Auriparus";

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
