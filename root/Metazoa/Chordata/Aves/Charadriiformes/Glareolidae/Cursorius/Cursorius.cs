using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Glareolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Glareolidae.Cursorius;

/// <summary>
/// Abstract class for Cursorius (genus).
/// NCBI TaxId: 227176
/// </summary>
public abstract class Cursorius : Glareolidae, ICursorius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cursorius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227176;

    /// <inheritdoc />
    public virtual string GenusName => "Cursorius";

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
