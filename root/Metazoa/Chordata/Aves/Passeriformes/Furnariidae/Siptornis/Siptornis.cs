using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Siptornis;

/// <summary>
/// Abstract class for Siptornis (genus).
/// NCBI TaxId: 589986
/// </summary>
public abstract class Siptornis : Furnariidae, ISiptornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Siptornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 589986;

    /// <inheritdoc />
    public virtual string GenusName => "Siptornis";

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
