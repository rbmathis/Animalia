using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Centropomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Centropomidae.Psammoperca;

/// <summary>
/// Abstract class for Psammoperca (genus).
/// NCBI TaxId: 329029
/// </summary>
public abstract class Psammoperca : Centropomidae, IPsammoperca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psammoperca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329029;

    /// <inheritdoc />
    public virtual string GenusName => "Psammoperca";

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
