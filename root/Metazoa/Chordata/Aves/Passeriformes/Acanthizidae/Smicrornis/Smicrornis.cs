using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Smicrornis;

/// <summary>
/// Abstract class for Smicrornis (genus).
/// NCBI TaxId: 117205
/// </summary>
public abstract class Smicrornis : Acanthizidae, ISmicrornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Smicrornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117205;

    /// <inheritdoc />
    public virtual string GenusName => "Smicrornis";

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
