using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Carpornis;

/// <summary>
/// Abstract class for Carpornis (genus).
/// NCBI TaxId: 649811
/// </summary>
public abstract class Carpornis : Cotingidae, ICarpornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carpornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 649811;

    /// <inheritdoc />
    public virtual string GenusName => "Carpornis";

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
