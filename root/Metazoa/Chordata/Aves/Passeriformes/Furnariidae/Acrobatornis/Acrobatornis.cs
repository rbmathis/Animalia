using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Acrobatornis;

/// <summary>
/// Abstract class for Acrobatornis (genus).
/// NCBI TaxId: 589930
/// </summary>
public abstract class Acrobatornis : Furnariidae, IAcrobatornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acrobatornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 589930;

    /// <inheritdoc />
    public virtual string GenusName => "Acrobatornis";

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
