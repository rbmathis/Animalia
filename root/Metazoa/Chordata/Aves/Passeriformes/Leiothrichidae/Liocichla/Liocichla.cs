using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Liocichla;

/// <summary>
/// Abstract class for Liocichla (genus).
/// NCBI TaxId: 201337
/// </summary>
public abstract class Liocichla : Leiothrichidae, ILiocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201337;

    /// <inheritdoc />
    public virtual string GenusName => "Liocichla";

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
