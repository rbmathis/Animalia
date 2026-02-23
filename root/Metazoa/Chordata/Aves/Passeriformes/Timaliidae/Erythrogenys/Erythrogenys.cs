using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Erythrogenys;

/// <summary>
/// Abstract class for Erythrogenys (genus).
/// NCBI TaxId: 1608426
/// </summary>
public abstract class Erythrogenys : Timaliidae, IErythrogenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erythrogenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1608426;

    /// <inheritdoc />
    public virtual string GenusName => "Erythrogenys";

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
