using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Hemixos;

/// <summary>
/// Abstract class for Hemixos (genus).
/// NCBI TaxId: 374656
/// </summary>
public abstract class Hemixos : Pycnonotidae, IHemixos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemixos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374656;

    /// <inheritdoc />
    public virtual string GenusName => "Hemixos";

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
