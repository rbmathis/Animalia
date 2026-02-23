using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Clinitrachus;

/// <summary>
/// Abstract class for Clinitrachus (genus).
/// NCBI TaxId: 57787
/// </summary>
public abstract class Clinitrachus : Clinidae, IClinitrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clinitrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57787;

    /// <inheritdoc />
    public virtual string GenusName => "Clinitrachus";

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
